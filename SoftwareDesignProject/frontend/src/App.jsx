import './App.css';
import { Route, Routes } from "react-router-dom";
import Navbar from './components/navbar';
import AplikimiCreate from './features/AplikimiCrud/aplikimi-create';
import GetAplikimet from './features/AplikimiCrud/aplikimi-get';
import FileUploader from './features/FileUpload/FileUploader';
import HomePage from './features/HomePage/HomePage';
import Dashboard from './features/Dashboard-drejtori/Dashboard';

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

                
            </Routes>
    
    </div>
  );
}

export default App;