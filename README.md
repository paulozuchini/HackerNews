# Hacker News API

**Hacker News Api** is a .Net 6.0 REST API that retrieves the details of the first 20 "best stories" from **Hacker News**.

## How to run
You must download the source code in this repository and then use the following commands in PowerShell **from the root** of the HackerNews repository:

```bash
dotnet build
dotnet run --project .\HackerNews.Controllers\HackerNews.Controllers.csproj
```

**OBS: You must have .NET CLI / SDK installed. If you don't have it, you can download it here:** [https://dotnet.microsoft.com/download/dotnet/6.0](https://dotnet.microsoft.com/download/dotnet/6.0)

## Usage

After running the application, open your preferred browser and try one of the URLs displayed in the log of the application. They are usually these:

* [http://localhost:5262/swagger](http://localhost:5262/swagger)
* [https://localhost:7262/swagger](https://localhost:7262/swagger)

I've made use of the Swagger UI in this project. With it, you can easily test the application by clicking the execute button. No additional configuration needed.

![Swagger](https://i.ibb.co/nmhXNKh/image.png)

## Considerations for the future
Due to the limited time I had I could not perform the following activities listed below for future consideration:

* Include Tests Project
* Include docker container registry
* Deploy docker container in the cloud (heroku or other free platform)
* Develop custom UI using Angular
 Implement some message broker for queue management (such as RabbitMQ)


## Contributing
Pull requests are not welcome at the moment. This is a test project for research only.

Please make sure to update tests as appropriate.

# Made by
**Paulo Zuchini**

[https://www.linkedin.com/in/paulozuchini/](https://www.linkedin.com/in/paulozuchini/)

## License
[MIT](https://choosealicense.com/licenses/mit/)
