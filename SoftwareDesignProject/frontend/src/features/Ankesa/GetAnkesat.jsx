import './AnkesaStyle.css';
import React,{ useState, useEffect } from 'react';
import axios from 'axios';

export default function GetAnkesat(){

  const[ankesat, setAnkesat] = useState([]);
  const [studentet, setStudentet] = useState([]);

  const [refreshKey, setRefreshKey] = useState('0');
      

  //get data from database
  useEffect(() => { 
    axios.get('https://localhost:7249/api/Ankesa')
        .then(response => {
            setAnkesat(response.data);
        })
  }, [refreshKey])

  useEffect(() => {
    axios.get('https://localhost:7249/api/Students/get-all-students')
    .then(response => {
        setStudentet(response.data);   
    }).catch(function(error){
        console.log(error);
    });
  },[refreshKey])

  //Delete data in database    
  function RefuzoAnkesen(id) {
    const confirmBox = window.confirm(
        "A jeni te sigurte qe deshironi te refuzoni ankesen me id " + id  +"?  " 
    )
    if (confirmBox === true) {
        axios.delete('https://localhost:7249/api/Ankesa/delete-ankesa?id=' + id)
            .then(() => {
                setRefreshKey(refreshKey => refreshKey + 1)
            })
    }
    else {
        console.log("Process of deleting an ankese canceled !!");
    }
  }

  return (
    <div className="ok">
      {ankesat.map((ankesa) => {
        const studentNrLeternjoftimit = ankesa.studentiNrLeternjoftimit;
        const permbajtja = ankesa.permbajtja;
        const student = studentet.find(studenti => studenti.nrLeternjoftimit === ankesa.studentiNrLeternjoftimit);
        const emri = student ? student.emri : "";
        const mbiemri = student ? student.mbiemri : "";
  
        return (
  
          <div className="student-card-container">
              <div className="student-card" key={studentNrLeternjoftimit}>
                <div className="student-info">
                  <p className="personal-number">Numri personal:   {studentNrLeternjoftimit}</p>
                  <p className="name">Name: {emri}</p>
                  <p className="surname">Surname: {mbiemri}</p>
                </div>
                <div className="student-complaint">
                  <p className="complaint-text">Permbajtja: {permbajtja}</p>
                  <div className="buttons-container">
                    <button className="accept-button">Prano</button>
                    <button type="button" onClick={() => RefuzoAnkesen(ankesa.id)} className="refuse-button">Refuzo</button>
                  </div>
                  
                </div>
              </div>
          </div>
        );
    })}
    </div>
  );
} 
