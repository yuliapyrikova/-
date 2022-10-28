from fastapi import FastAPI
import requests
app = FastAPI()
URL = 'http://127.0.0.1:8000/'

@app.get('/api/check')
def check():
    return 'check is successful...'

@app.get('/external')
def home():
    response = requests.get(URL)
    response_value = response.json()
    return response_value