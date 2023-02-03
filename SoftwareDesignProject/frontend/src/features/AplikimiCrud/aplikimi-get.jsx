import axios from "axios";
import React, { useEffect, useState } from "react";
import { toast } from "react-toastify";
import './style.css'
import Delete from './bin.png';

export default function GetAplikimet(){

    const [aplikimet,setAplikimet] = useState([]);
    const [studentet, setStudentet] = useState([]);
    const [fakultetet,setFakultetet] = useState([]);
    const [refreshKey,setRefreshKey] = useState(0);
    const [files, setFiles] = useState([]);

    useEffect(() => {
        axios.get('https://localhost:7249/api/Aplikimi')
        .then(response => {
            setAplikimet(response.data);
        }).catch(function(error){
            console.log(error);
        });
    },[refreshKey])


    useEffect(() => {
        axios.get('https://localhost:7249/api/Students/get-all-students')
        .then(response => {
            setStudentet(response.data);   
        }).catch(function(error){
            console.log(error);
        });
    },[refreshKey])

    
    useEffect(() => {
        axios.get('https://localhost:7249/api/Fakulteti')
        .then(response => {
            setFakultetet(response.data);   
        }).catch(function(error){
            console.log(error);
        });
    },[refreshKey])

    useEffect(() => {
        axios.get('https://localhost:7249/api/Files')
        .then(response => {
            setFiles(response.data);   
        }).catch(function(error){
            console.log(error);
        });
    },[refreshKey])

    


    // function handleDeleteStudent(id) {
    //     const confirmBox = window.confirm(
    //         "Delete student with id: " + id + '?'
    //     )
    //     if(confirmBox === true){
    //         axios.delete('https://localhost:7249/api/Aplikimi/delete-aplikimi?id='+id )
    //         .then(() => {
    //             setRefreshKey(refreshKey => refreshKey + 1)
    //         }).catch(function (error){
    //             console.log(error);
    //         });
    //     }
    //     else{
    //         toast.error("Process of deleting this student canceled!");
    //     }
    // }



    return(
        <>
        <h4>Te gjitha aplikimet</h4>

        <div className="get-aplikimet">
            <table className="table-get-aplikimet">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Special Category</th>
                        <th>Apply Date</th>
                        <th>Numri Personal</th>
                        <th>Emri</th>
                        <th>Emri i Prindit</th>
                        <th>Mbiemri</th>
                        <th>Qyteti</th>
                        <th>Gjinia</th>
                        <th>Viti i Studimeve</th>
                        <th>Nota Mesatare</th>
                        <th>Statusi</th>
                        <th>Drejtimi</th>
                        <th>Departamenti</th>
                        <th>File Name</th>
                    </tr>
                </thead>

                <tbody>
                    {aplikimet.map((aplikimi) => (
                        <tr key={aplikimi.id}>
                            <th>{aplikimi.id}</th>
                            <th>{aplikimi.specialCategoryReason}</th>
                            <th>{aplikimi.applyDate}</th>
                           <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.nrLeternjoftimit : ""
                                
                            ))}
                            </th>
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.emri : ""
                                
                            ))}
                            </th>
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.emriIPrindit : ""
                                
                            ))}
                            </th>
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.mbiemri : ""
                                
                            ))}
                            </th>
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.qyteti : ""
                                
                            ))}
                            </th>
                          
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.gjinia : ""
                                
                            ))}
                            </th>
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.vitiIStudimeve : ""
                                
                            ))}
                            </th>
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.notaMesatare : ""
                                
                            ))}
                            </th>
                            <th>
                            {studentet.map((studenti) => (
                                (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit) ? studenti.statusi : ""
                                
                            ))}
                            </th>
                            <th>
                                {studentet.map((studenti) => (
                                    fakultetet.map((fakulteti) => (
                                        (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit &&  studenti.fakultetiId == fakulteti.id ) ? 
                                         fakulteti.drejtimi : ""
                                    ))
                                ))}                                          
                            </th>  
                            <th>
                                {studentet.map((studenti) => (
                                    fakultetet.map((fakulteti) => (
                                        (studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit &&  studenti.fakultetiId == fakulteti.id ) ? 
                                         fakulteti.departamenti : ""
                                    ))
                                ))}
                                           
                            </th>           

                                <th>
                                    {files.map((file) => (
                                        (aplikimi.fileId == file.id ) ? 
                                        file.fileName : ""
                                ))}           
                            </th>                
                      </tr> 
                       ))}    
                </tbody>
            </table>
        </div>

        </>
    )
}