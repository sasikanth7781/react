import React,{useState,useEffect,useRef}from "react";
import axios from "axios";
import { useNavigate } from 'react-router';
function Patient() {
    const navigate=useNavigate();
    function age(Dob){
    var dob = new Date(Dob);
    var month_diff = Date.now() - dob.getTime();
    var age_dt = new Date(month_diff); 
    var year = age_dt.getUTCFullYear();
    var age = Math.abs(year - 1970);
    return age;
    }
//get state name
function getStateName(id,id1){
    axios.get(`https://localhost:44330/api/State/${id}`).then((res)=>{
        document.getElementById('s'+id1+id).innerHTML=res.data.result.name
    }
    )
    
}

//get city name
function getCityName(id,id1){
    axios.get('https://localhost:44330/api/City').then((res)=>{
        for(const c of res.data.result){
            if(c.id==id){
                document.getElementById('c'+id1+id).innerHTML=c.name
            }
        }
    }
    )
    
}
//getting data to show
    const [data,setData]=useState([]);
    useEffect(()=>{
        axios.get("https://localhost:44330/api/Question").then(
            (res)=>{
                setData(res.data.result)
            }
        )
    },[])
    console.log('usestate')
    console.log(data)
    return (<div>
        <br></br>
  <br></br>
<button onClick={()=>navigate('/create')} >Add</button>
<br></br>
<br></br>
        <table>
        <tr>
        <th>Full Name</th>
        <th>Gender</th>
        <th>Age</th>
        <th>Email</th>
        <th>state</th>
        <th>city</th>
        <th>Interested in personal training services?</th>
        <th colSpan='2'>Actions</th>
        </tr>
        {
      data.map((row,index)=>
        <tr key={index}>
            <td>{row.first_name+row.last_name}</td>
            <td>{row.gender?'male':'female'}</td>
            <td>{age(row.dob)}</td>
            <td>{row.email}</td>
            <td id={'s'+row.id+row.s_id}>{row.s_id
}</td>
            <td id={'c'+row.id+row.c_id}>{row.c_id}</td>
            <td>{row.need_trainer?'yes':'no'}</td>
            <td><button onClick={()=>navigate(`/delete/${row.id}`)} >Delete</button></td>
            <td><button onClick={()=>navigate(`/update/${row.id}`)} >Edit </button></td>
            </tr>)}
    </table></div>) 
}
export default Patient;