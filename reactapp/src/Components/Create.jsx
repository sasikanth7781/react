import {useState, useEffect, useRef} from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router';
function Create(){
    const navigate=useNavigate()
    const f1=useRef();
    const f2=useRef();
    const f4=useRef();
    const f5=useRef();
    const f6=useRef();
    const f7=useRef();
    const f8=useRef();
    const f9=useRef();
    const f10=useRef();
    const f13=useRef();
    //insert diets

function postcall() {
    const payload={}
//1
const gender = document.querySelectorAll('input[name="gender"]')
for (const f of gender) {
  if (f.checked) {
    payload.gender=f.value=='1'?true:false
  }
}
//2
const level = document.querySelectorAll('input[name="level"]')
for (const f of level) {
  if (f.checked) {
    payload.question2=f.value
  }
}
//3
const suffer = document.querySelectorAll('input[name="suffer"]')
for (const f of suffer) {
  if (f.checked) {
    payload.question3=f.value=='1'?true:false
  }
}
//4
const exer = document.querySelectorAll('input[name="exer"]')
for (const f of exer) {
  if (f.checked) {
    payload.regular_exercise=f.value=='1'?true:false
  }
}
//5
const trainer = document.querySelectorAll('input[name="trainer"]')
for (const f of trainer) {
  if (f.checked) {
    payload.need_trainer=f.value=='1'?true:false
  }
}
//end
payload.first_name=f1.current.value
payload.last_name=f2.current.value
payload.dob=f4.current.value
payload.email=f5.current.value
payload.s_id=f6.current.value
payload.c_id=f7.current.value
payload.height=f8.current.value
payload.weight=f9.current.value
payload.question1=f10.current.value
payload.problems=f13.current.value

axios.post("https://localhost:44330/api/Question",payload).then((res)=>{
    navigate("/")
})
    }
//get states
       useEffect(()=>{axios.get("https://localhost:44330/api/State").then(
            (res)=>{
                var ele1=document.getElementById("state")
                res.data.result.forEach(element => {
                  var option = document.createElement("option");
                    option.value =element.id;
                    option.text =element.name;
                    ele1.appendChild(option);
                });
            }
        )},[])
//get cities by state
    function cityval() {
        console.log("called city val");
        var selectElement = document.querySelector('#state');
        var output = selectElement.value;
        console.log(output)
        axios.get("https://localhost:44330/api/City/"+output).then(
                (res)=>{
                    console.log(res.data.result)
                    var ele1=document.getElementById("city")
                    ele1.innerHTML=""
        res.data.result.forEach(element => {
          var option = document.createElement("option");
            option.value =element.id;
            option.text =element.name;
            ele1.appendChild(option);
        });      
        })
    }
    return (<form>
        <label>first name</label>
        <input type="text" ref={f1}/>
        <br/>
        <label>last name</label>
        <input type="text" ref={f2}/>
        <br></br>
        <label>Gender</label>
        <input type="radio" id="r1" name="gender" value="1" ></input>
        <label for="r1">Male</label><br></br>
        <input type="radio" id="r2" name="gender" value="0"></input>
        <label for="r2">Female</label><br></br>
        <br/>
        <label for="birthday">Date of birth:</label>
        <input type="date" id="birthday" name="birthday" ref={f4}></input>
        <br/>
        <label for="email">Email</label>
        <input type="email" ref={f5}>
        </input>
        <br></br>
        <label> State </label>  
<select id="state" onChange={cityval} ref={f6}>
<option selected disabled hidden>select</option>
</select>
<label>city</label>
<select id="city" ref={f7}>
<option selected disabled hidden>Select State First</option>
</select>
<br></br>
<label for="height">Height</label>
<input type='text' id='height' ref={f8}></input>
<br></br>
<label for="weight">Weight</label>
<input type='text' id='weight' ref={f9}></input>
<br></br>
<label for="q1">What do you do for living?</label>
<input type='text' id='q1' ref={f10}></input>
<br></br>
<label >What is the activity level at your job?</label>
<br></br>
<label for="c6">none(seated only)</label>
<input id="c6" type='checkbox' value="0" name='level'/>
<label for="c7">Moderate(light activity such as walking)</label>
<input id="c7" type='checkbox' value="1" name='level'/>
<label for="c8">High(heavy labour very active)</label>
<input id="c8" type='checkbox' value="2" name='level'/>
<br></br>
<label >Do you suffer from diabetes,asthma,high or low blood pressure?</label>
<input type="radio" id="r3" name="suffer" value="1"/>
        <label for="r3">Yes</label><br></br>
        <input type="radio" id="r4" name="suffer" value="0"/>
        <label for="r4">No</label><br></br>
<label for="q3">if you have any diagnosed health problems,please list</label>
<br></br>
<textarea rows = "5" cols = "60" name = "description" id="q3" ref={f13}/>
<br></br>
<br/>
<label >Your current diet could be best characterized as:</label>
<br></br>
<label for="c1">low-fat</label>
<input id='c1' type='checkbox' name='diet' value="1"/>
<br></br>
<label for="c2">low-carb</label>
<input id="c2" type='checkbox' name='diet' value="2"/>
<br></br>
<label for="c3">high-protein</label>
<input id="c3" type='checkbox'  name='diet' value="3"/>
<br></br>
<label for="c4">Vegetarain/Vegan</label>
<input id="c4" type='checkbox' name='diet' value="4"/>
<br></br>
<label for="c5">No special diet</label>
<input id="c5" type='checkbox' name='diet' value="5"/>
<br></br>
<label>Are you currently exercising regularly(atleast 3x per week)?</label>
<input type="radio" id="r5" name="exer" value="1"/>
        <label for="r5">Yes</label><br></br>
        <input type="radio" id="r6" name="exer" value="0" />
        <label for="r6">No</label><br></br>
<label>Would you like to avail the services of a personal trainer?</label>
<input type="radio" id="r7" name="trainer" value="1"/>
        <label for="r7">Yes</label><br></br>
        <input type="radio" id="r8" name="trainer" value="0" />
        <label for="r8">No</label><br></br>
    <input type="button" value="Create" onClick={postcall}/>
    </form>)

}
export default Create;