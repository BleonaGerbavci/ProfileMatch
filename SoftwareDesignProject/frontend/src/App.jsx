import './App.css';
import { Route, Routes } from "react-router-dom";
import Navbar from './components/navbar';
import AplikimiCreate from './features/AplikimiCrud/aplikimi-create';
import GetAplikimet from './features/AplikimiCrud/aplikimi-get';
import FileUploader from './features/FileUpload/FileUploader';
import HomePage from './features/HomePage/HomePage';
import Dashboard from './features/Dashboard-drejtori/Dashboard';
import Lista from './features/Listaa/Lista';
import Footer from './components/footer';

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

            
            </Routes>
            
    
    </div>
  );
}

export default App;