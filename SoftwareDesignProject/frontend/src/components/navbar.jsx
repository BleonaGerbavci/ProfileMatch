import React from "react";
import { Link } from "react-router-dom";
import "./navbar.css"
import Dashboard from "../features/Dashboard-drejtori/Dashboard";
import HomePage from './../features/HomePage/HomePage';

export default function Navbar()
{
    return(
        <div className="navbar">
            <div className="logo">
                {/* <p>Qendra e studenteve</p> */}
            </div>

            <div className="navbar-links">
                <Link to="./HomePage">
                    <p>Home</p>
                </Link>
                <Link to="./AnkesaAdd">
                   <p>Ankesa</p> 
                </Link>
                
                <Link to=".">
                   <p>Konkursi</p> 
                </Link>
                <Link to="./AplikimiCreate">
                   <p>Apliko</p> 
                </Link>
                <Link to="./Dashboard">
                   <p>Dashboard</p> 
                </Link>
                <Link to=".">
                    <p>Sign up</p> 
                </Link> 
                

            <div className="butoni-signUp">
                <Link to="/">
                    <button type="button" className="sign-in-btn">Sign in</button>
                </Link>
            </div>
           
        </div>
        </div>
    )
}