# Aspire Django orchestration demo

This repo demonstrates how you can connect Django to Aspire. Right now, this is broken. You won't receive a response, unless you don't use the Dcp proxy.

## System requirements

- Python 3.12
- .NET Aspire Preview 7

## Running the demo

Please make sure to create a new virtual environment in the django-app folder:

```powershell
cd django-app
python -m venv .venv
```

Next, install the dependencies with the virtual environment activated:

```
. .venv/scripts/activate.ps1
pip install -r requirements.txt
```

Note, you don't need to have the virtual environment active for Aspire to orchestrate the app.
You can deactivate the environment by running the command `deactivate`.

Once deactivated, you can run the host by executing the following command:

```powershell
cd AspireDjangoDemo.Host
dotnet run
```
