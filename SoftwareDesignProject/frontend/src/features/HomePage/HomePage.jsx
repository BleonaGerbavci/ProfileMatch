import React from 'react';
import './home-page.css'
import { Link } from 'react-router-dom';
import Ankesa from './complaint.png';
import AplikimiCreate from '../AplikimiCrud/aplikimi-create';
import Lista from './list.png';
import Konkursi from './application.png';
import Footer from '../../components/footer';

export default function HomePage()
{
    return(
        
        <div className='base-container'>

            <div className='main-div'>
                <div className='ballina-title'>MIRE SE VINI</div>
            </div>

            <div className='udhezuesit'>
                <Link to=".">
                   Udhezuesi per aplikim 
                </Link>
                <Link to=".">
                   Udhezuesi per pagesa
                </Link>
            </div>

            <div className='njoftimet'>
                <p className='njoftimet-e-reja-title'>Njoftimet e reja</p>

                <div className='njoftimet-div'>
                <Link to='/Ankesat'>
                    <img src={Ankesa} />
                </Link>
                <Link to='/Lista'>
                    <img src={Lista}/>
                </Link>
                <Link to='/AplikimiCreate'>
                    <img src={Konkursi}/>
                </Link>
                </div>
                <div className='njoftimet-p'>
                    <p>Hapet konkursi per ankese</p>
                    <p>Lista e rezultateve 22/23</p>
                    <p>Hapet konkursi per aplikim <br/> per vitin 2022/23</p>
                </div>

            </div>
            <Footer/>
        </div>
    )
}