import axios from "axios";
import React, { useEffect, useState } from "react";
import "./ListaStyle.css";

export default function ListaEPritjes(){

  const [aplikimet,setAplikimet] = useState([]);
    const [studentet, setStudentet] = useState([]);
    const [fakultetet,setFakultetet] = useState([]);
    const [refreshKey,setRefreshKey] = useState(0);
    const [profileMatches, setProfileMatches] = useState([]);

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
        axios.get('https://localhost:7249/api/ProfileMatch/last10')
        .then(response => {
            setProfileMatches(response.data);   
        }).catch(function(error){
            console.log(error);
        });
    },[refreshKey])

 
  return(
  <>
  <h2>Lista e pritjes</h2>
  <div className="table-containerT">
    <table className="tableT">
      <thead>
        <tr>
          <th className="table-header-cellT">#</th>
          <th className="table-header-cellT">Emri</th>
          <th className="table-header-cellT">Mbiemri</th>
          <th className="table-header-cellT">Fakulteti</th>
          <th className="table-header-cellT">Komuna</th>
          <th className="table-header-cellT">Pike nota mesatare</th>
          <th className="table-header-cellT">Pike qyteti</th>
          <th className="table-header-cellT">Pike distance</th>
          <th className="table-header-cellT">Totali</th>
        </tr>
      </thead>
      <tbody>
      {profileMatches.map((profileMatch, index) => (
        <tr className="table-rowT" key={profileMatch.id}>
          <td className="table-cellT">{index + 1}</td>
          <td className="table-cellT">
          {aplikimet.map((aplikimi) => (
                                    studentet.map((studenti) => (
                                        (profileMatch.aplikimiId ===aplikimi.id  &&studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit)? 
                                         studenti.emri : ""
                                    ))
                                ))}
          </td>
          <td className="table-cellT">
          {aplikimet.map((aplikimi) => (
                                    studentet.map((studenti) => (
                                        (profileMatch.aplikimiId ===aplikimi.id  &&studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit)? 
                                         studenti.mbiemri : ""
                                    ))
                                ))}
          </td>
          <td className="table-cellT">
          {aplikimet.map((aplikimi) => (
                                    studentet.map((studenti) => (
                                      fakultetet.map((fakulteti) => (
                                        (profileMatch.aplikimiId ===aplikimi.id  &&studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit && studenti.fakultetiId == fakulteti.id)? 
                                         fakulteti.departamenti : ""
                                        ))
                                        
                                    ))
                                ))}
          </td>
          <td className="table-cellT">
          {aplikimet.map((aplikimi) => (
                                    studentet.map((studenti) => (
                                        (profileMatch.aplikimiId ===aplikimi.id  &&studenti.nrLeternjoftimit == aplikimi.studentiNrLeternjoftimit)? 
                                         studenti.qyteti : ""
                                    ))
                                ))}
          </td>
          <td className="table-cellT">{profileMatch.pointsForGPA}</td>
          <td className="table-cellT">{profileMatch.pointsForCity}</td>
          <td className="table-cellT">{profileMatch.extraPoints}</td>
          <td className="table-cellT">{profileMatch.totalPoints}</td>
        </tr>
      ))}
      </tbody>
    </table>
  </div>
  </>
);
}
