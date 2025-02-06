
import flask

app = Flask(name)

@app.route("/")
def home():
	return ("Filip == grøndlænder")
