# About Take Blip Challenge
Repository created to return the 5 oldest Take Blip's repositories on GitHub and json upload to chatbot created on Blip platform.


## **Technologies**

#### [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/) + [Docker](https://www.docker.com/) + [Azure](https://azure.microsoft.com/pt-br/)


## Deploy Azure 
The deploy was done at Azure Cloud. Link to access: https://challengetakeblip.azurewebsites.net/api/GitHub

*To Swagger run on the cloud:* https://challengetakeblip.azurewebsites.net/swagger/index.html

## **How To Local Start **

*To local run:* Start the program in your editor of choice and it will launch on localhost:5001, so you can test the endpoint (GET : /api/GitHub).

*To Swagger run on the local enviroment :* https://localhost:5001/swagger/index.html


## **Running With Docker**

Access the directory where the repository was cloned through the terminal and execute the commands:

"docker build -t challenge-take ."
"docker run -p 8181:80 challenge-take"

To creat and execult the container =)


