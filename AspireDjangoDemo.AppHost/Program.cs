var builder = DistributedApplication.CreateBuilder(args);

builder.AddExecutable("django-app", "../django-app/.venv/scripts/python", "../django-app", "manage.py", "runserver")
  .WithHttpEndpoint(targetPort: 8000, env: "DJANGO_HTTP_PORT", name: "http")
  .PublishAsDockerFile();

builder.Build().Run();
