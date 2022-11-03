import './App.css';
import {Routes,Route} from 'react-router-dom';
import Patient from './Components/Patient';
import Create from './Components/Create';
import Update from './Components/Update'
import Delete from './Components/Delete';
function App() {
return(
<div>
<Routes>
<Route path='/' element={<Patient/>}></Route>
</Routes>
<Routes>
<Route path='/create' element={<Create/>}></Route>
</Routes>
<Routes>
<Route path='/update/:id' element={<Update/>}></Route>
</Routes>
<Routes>
<Route path='/delete/:id' element={<Delete/>}></Route>
</Routes>
</div>)
}

export default App;