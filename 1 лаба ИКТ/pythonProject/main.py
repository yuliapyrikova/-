from fastapi import FastAPI

app = FastAPI()


@app.get('/')
def home():
    return {
        "Name": "Yulia",
        "Age": "20"
    }

