
import Footer from "../../components/footer";
import "./AnkesaStyle.css"
import { React,  useState } from 'react';
import axios from 'axios';
import { useNavigate } from "react-router-dom";

export default function AnkesaAdd(){

    const [refreshKey, setRefreshKey] = useState('0');

    const navigate = useNavigate();

     //Set data to database
     const [permbajtja, setPermbajtja] = useState('');
     const [studentiNrLeternjoftimit, setStudentiNrLeternjoftimit] = useState('');


     const handleAdd = (e) => {
        e.preventDefault();
        const ankesat = { permbajtja, studentiNrLeternjoftimit };

        axios.post('https://localhost:7249/api/Ankesa/add-ankesa', ankesat)
            .then(() => {
               window.alert('Ankesa u shtua me sukses!');
               
            })
            .then(() => {
            setRefreshKey(refreshKey => refreshKey + 1)
        })
    }

    return (
        <>
        <form className="form-containerA" onSubmit={handleAdd}>
            <input
            id="personal-number"
            type="number"
            className="fieldA"
            value={studentiNrLeternjoftimit}
            onChange={(e) => setStudentiNrLeternjoftimit(e.target.value)}
            placeholder="Numri Personal"
            />
            <textarea
            id="complaint"
            className="textarea-fieldA"
            value={permbajtja}
            onChange={e => setPermbajtja(e.target.value)}
            placeholder="Shkruani ankesen tuaj këtu..."
            />
            <button type="submit" className="submit-buttonA">
            Submit
            </button>
        </form>
        <Footer/>
        </>
    );
};



