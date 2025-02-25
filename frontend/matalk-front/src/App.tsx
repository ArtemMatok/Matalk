import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import './App.css'
import RegLogPage from './pages/RegLogPage'

const App = () => {
  return (
    <Router>
      <Routes>
      <Route path="/" element={<div>Welcome to the Home Page</div>} />
        <Route path='/login' element={<RegLogPage />} />
      </Routes>
    </Router>
  )
}

export default App;
