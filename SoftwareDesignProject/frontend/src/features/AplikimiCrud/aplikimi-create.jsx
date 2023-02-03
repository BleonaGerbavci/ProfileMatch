import axios from "axios";
import React, { useEffect, useState } from "react";
import { toast } from "react-toastify";
import "./style.css";
import FileUploader from '../FileUpload/FileUploader';

export default function AplikimiCreate(){
    
    const [studenti, setStudenti] = useState({});
    const [studentiNrLeternjoftimit, setStudentiNrLeternjoftimit] = useState(0);
    const [isLoading, setIsLoading] = useState(false);
    const [isSpecialCategory, setIsSpecialCategory] = useState(false);
    const [specialCategoryReason,setSpecialCategoryReason] = useState("");
    const applyDate = Date.now;
    const [refreshKey, setRefreshKey] = useState('0');
    const [error, setError] = useState(false);
    const [fileId, setFileId] = useState();

    
    // useEffect(() => {
    //     axios.get("https://localhost:7249/api/Files/GetFileById?fileId=" + fileId)
    //     .then(response => {
    //         setFileId(response.data);
    //     }).catch(function(error){
    //         console.log(error);
    //     });
    // })

    const handleSubmit = (e) => {
        e.preventDefault();   
        const apliko = {isSpecialCategory,specialCategoryReason,applyDate,studentiNrLeternjoftimit,fileId};
         // Validimi
        
        if(studentiNrLeternjoftimit == 0){
            setError(true)
        }
        if(applyDate != Date.now){
            setError(true)
        }
        console.log(apliko)
            axios.post('https://localhost:7249/api/Aplikimi/add-aplikimi', apliko)
            .then(() => {
                toast.success("Ju aplikuat me sukses!", {theme:"colored"})
            })
            .then(() => {
                setRefreshKey(refreshKey => refreshKey + 1)
            }).catch(function (error){
                console.log(error);
            });
    }

   
    

    return(
        <div className="aplikimi-container">

            <h3>Faqja Zyrtare e Aplikimit</h3>
            <form onSubmit={handleSubmit} className="form-aplikimi-create">
                <br/>
                <input 
                    type="number"
                    name="nrPersonal"
                    placeholder="Numri Personal"
                    onChange={(e) => setStudentiNrLeternjoftimit(e.target.value)} /> <br/>
                {error ? 
                <label className="label-1">Personal number can't be empty! !</label>: ""} <br/> <br/>                               

                <label htmlFor="po" className="title-aplikimi">A i takoni ndonjeres kategori te vecante?</label> <br/><br/>
                <input
                    type="radio" 
                    name="Po" 
                    checked={isSpecialCategory === true}
                    value="Po"
                    onChange={() => setIsSpecialCategory(true)}
                   />Po
                    <br/> <br/>

                <input
                    type="radio" 
                    name="Jo" 
                    checked={isSpecialCategory === false}
                    value="Jo"
                    onChange={() => setIsSpecialCategory(false)}
                  /> Jo
                    <br/> <br/>

                <select 
                    name="categoryreason" 
                    required
                    onChange={(e) => setSpecialCategoryReason(e.target.value)}
                    disabled={!isSpecialCategory}
                    defaultValue={specialCategoryReason}
                    className="category-reason"
                    >
                    
                        <option value="Zgjedh Kategorine" onChange={(e) => setSpecialCategoryReason(e.target.value)}>Zgjedh Kategorine</option>
                        <option value="Student (femije) i deshmorit" onChange={(e) => setSpecialCategoryReason(e.target.value)} >Student (femije) i deshmorit</option>
                        <option value="Student (femije) i prindit invalid te luftes" onChange={(e) => setSpecialCategoryReason(e.target.value)} >Student (femije) i prindit invalid te luftes</option>
                        <option value="Student (femije) i prindit veterean te luftes" onChange={(e) => setSpecialCategoryReason(e.target.value)} >Student (femije) i prindit veterean te luftes</option>
                        <option value="Student (femije) i te pagjeturit" onChange={(e) => setSpecialCategoryReason(e.target.value)} >Student (femije) i te pagjeturit</option>
                        <option value="Student invalid civil i luftes" onChange={(e) => setSpecialCategoryReason(e.target.value)}>Student invalid civil i luftes</option>
                        <option value="Student i prindit martir nga lufta" onChange={(e) => setSpecialCategoryReason(e.target.value)}>Student i prindit martir nga lufta</option>
                        <option value="Student me aftesi te kufizuara" onChange={(e) => setSpecialCategoryReason(e.target.value)}>Student me aftesi te kufizuara</option>
                        <option value="Student i te burgosurit" onChange={(e) => setSpecialCategoryReason(e.target.value)}>Student i te burgosurit </option>
                        <option value="Student me asistence sociale" onChange={(e) => setSpecialCategoryReason(e.target.value)}>Student me asistence sociale</option>
                        <option value="Dy e me shume student nga nje familje aplikant ne QS" onChange={(e) => setSpecialCategoryReason(e.target.value)}>Dy e me shume student nga nje familje aplikant ne QS</option>

                </select>  <br/> <br/>

                <input 
                    type="date" 
                    defaultValue={Date.now}
                />
                <br/>
                    {error ? 
                <label className="label-1">Select today date!</label>: ""} 
                <br/> <br/>
                
                <button className="buton-aplikimi" >Apliko</button>

                
            </form>

            <div>
                <FileUploader/>
            </div>
        </div>
    )



}