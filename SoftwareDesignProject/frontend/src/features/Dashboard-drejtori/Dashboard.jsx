import React from "react";
import Navbar from "../../components/navbar";
import GetAplikimet from "../AplikimiCrud/aplikimi-get";
import Person from './user.png';
import Applications from './resume.png';
import Ankesat from './bad-review.png';
import { Link } from "react-router-dom";
import './dashboard.css'
import Footer from "../../components/footer";

export default function Dashboard(){

    return (
    <div className="container-div-dashboard">

        
        <div className="profili-im"> 
        <h4 className="profili-h5">PROFILI IM</h4>
            <div className="left-black-div">
           
                <p>Numri Personal</p>
                <p>Emri dhe Mbiemri</p>
                <p>Vendlindja</p>
                <p>Numri i Telefonit</p>
                <p>Email</p>
            </div>
            <div className="right-white-div">
                <div className="nrPersonal">
                    <p>12345678</p>
                </div>
                <div className="emri-mbiemri">
                    <p>Filan Fisteku</p>
                </div> 
                <div className="vendlindja">
                    <p>Prishtine</p>
                </div>   
                <div className="nrTel">
                    <p>44123456</p>
                </div>  
                <div className="email">
                    <p>filanfisteku@gmail.com</p>
                </div>        
            </div>
        </div>

        <div className="total-students">
            <div className="left-total-div">
                <div>
                <p>Total Students</p>
                <p>3560</p>
                </div>
                <img src={Person} className="img-total" />     
            </div>  
        </div>

        <div className="Aplikimet">
            <div className="img-aplikimet">
                <Link to='/GetAplikimet'>
                    <img src={Applications} />
                </Link>
                <p>Te gjitha aplikimet</p>
            </div>
        </div>

        <div className="Ankesat">
            <div className="img-ankesat">
                <Link to='/GetAnkesat'>
                    <img src={Ankesat} />
                </Link>
                <p>Ankesat</p>
            </div>
        </div>

        <div className="konvikti-div">
            <div className="konviktet-p">
                <p>Konvikti 1</p>
                <p>Konvikti 2</p>
                <p>Konvikti 3</p>
                <p>Konvikti 4</p>
                <p>Konvikti 5</p>
                <p>Konvikti 6</p>
                <p>Konvikti 7</p>
                <p>Konvikti 8</p>
            </div>

            <div className="konviktet-gjinia">
                <p>Gjinia: Femra</p>
                <p>Gjinia: Meshkuj</p>
                <p>Gjinia: Femra</p>
                <p>Gjinia: Meshkuj</p>
                <p>Gjinia: Femra</p>
                <p>Gjinia: Femra</p>
                <p>Gjinia: Femra</p>
                <p>Gjinia: Meshkuj</p>
            </div>

            <div className="konviktet-fk">
                <p>Fakulteti: Filozofik,Ekonomik,Matematikor</p>
                <p>Fakulteti: Filozofik,Ekonomik,Matematikor</p>
                <p>Fakulteti: FIEK,Arkitekure,Teknik</p>
                <p>Fakulteti: FIEK,Arkitekure,Teknik</p>
                <p>Fakulteti: Art,Juridik,Edukim</p>
                <p>Fakulteti: Mjekesi</p>
                <p>Fakulteti: FEFS,Bujqesi,Mjekesi</p>
                <p>Fakulteti: Mjekesi</p>
            </div>        
        </div>
        <div className="footer-dashboard">
                <Footer/>
            </div>
    </div>
    )
}