import React, {useState, useEffect} from 'react';
import './App.css';
import axios from 'axios'

const App = () => {
    const [doggo, setDoggo] = useState(null)
    const [love, setLove] = useState(null)
    const [dogService, setDogService] = useState(null)

  useEffect(() => {
    axios.get('https://dog.ceo/api/breeds/image/random')
      .then((response) => {
        console.log('sasha.data.message: ',  response.data.message)
        setDoggo(response.data.message)
      })
      .catch((error) => {
        console.log('Error fetching dog picture: ', error)
      })

    const fname = 'Lucas'
    const sname = 'Sasha'

    axios.get(`https://love-calculator.p.rapidapi.com/getPercentage?fname=${fname}&sname=${sname}`,
     {
      headers: {
        "x-rapidapi-host": "love-calculator.p.rapidapi.com",
        "x-rapidapi-key": "dc4c55f586msh375fc415a7750c3p163853jsnba29855ee4cb",
      }
    }).then(response => {
        console.log('response: ', response.data)
        setLove(response.data)
    }).catch(err => {
      console.log('err: ', err)
    })

    axios.get('https://dog-spring-boot-example.herokuapp.com/dogs/')
        .then(res => {
            console.log('res: ', res)
            setDogService(res.data)
        })
     
  }, [])

  return (
    <div className="App">
      <p>Hello</p>
        <img src={doggo} alt="doggo" height={300} />
        {love && (
          <div>
            <p>Love result: {love.result}</p>
            <p>Love percentage: {love.percentage}</p>
          </div>
        )}
        {dogService && (
            <div>
                <p>Dog service result: {dogService}</p>
            </div>
        )}
    </div>
  );
}

export default App;
