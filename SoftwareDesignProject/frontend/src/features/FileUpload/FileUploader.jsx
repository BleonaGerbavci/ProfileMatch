import React, { useState } from 'react';
import axios from 'axios';
import './FileStyle.css';



const FileUploader = () => {
  const [file, setFile] = useState(null);

  const handleFileChange = event => {
    setFile(event.target.files[0]);
  };

  const handleSubmit = async event => {
    event.preventDefault();
    const formData = new FormData();
    formData.append('fileData', file);
    try {
      const response = await axios.post('https://localhost:7249/api/Files/PostSingleFile', formData);
      console.log(response.data);
    } catch (error) {
      console.error(error);
    }
  };

  return (
   
    <form className='form-fileUploader' onSubmit={handleSubmit}>
      <input 
        type="file" 
        onChange={handleFileChange} 
        />
      <button type="submit">Upload</button>
    </form>
  
  );
};

export default FileUploader;