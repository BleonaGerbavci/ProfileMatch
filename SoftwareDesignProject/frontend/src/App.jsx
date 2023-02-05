import './App.css';
import { Route, Routes } from "react-router-dom";
import Navbar from './components/navbar';
import AplikimiCreate from './features/AplikimiCrud/aplikimi-create';
import GetAplikimet from './features/AplikimiCrud/aplikimi-get';
import FileUploader from './features/FileUpload/FileUploader';
import HomePage from './features/HomePage/HomePage';
import Dashboard from './features/Dashboard-drejtori/Dashboard';
import Lista from './features/Lista/Lista';
import Footer from './components/footer';
import AnkesaAdd from './features/Ankesa/AnkesaAdd';
import GetAnkesat from './features/Ankesa/GetAnkesat';
import ListaEPritjes from './features/Lista/ListaEPritjes';

function App(){
  return (
    <div className="App">  
            <Navbar />
            <Routes>
                <Route path='/GetAplikimet' element={<GetAplikimet/>} />  
                <Route path='/AplikimiCreate' element={<AplikimiCreate/>} />
                <Route path='/FileUploader' element={<FileUploader/>} />
                <Route path='/HomePage' element={<HomePage/>} />
                <Route path='/Dashboard' element={<Dashboard/>} />
                <Route path='/Lista' element={<Lista/>} />
                <Route path='/AnkesaAdd' element={<AnkesaAdd/>} />
                <Route path='/GetAnkesat' element={<GetAnkesat/>} />
                <Route path='/ListaPritjes' element={<ListaEPritjes/>} />

            
            </Routes>
            
            
    
    </div>
  );
}

export default App;