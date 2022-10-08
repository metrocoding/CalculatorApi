## Calculator API

### Run:
#### 1. Execute command to activate ElasticSearch and Kibana
```
docker-compose up -d
```
- ElasticSearch: http://localhost:9200
- Kibana: http://localhost:5601


#### 2. Run the server with this command
```
dotnet run --project ./Calculator/Calculator.csproj
```

#### 3. Visit [LOCALHOST](https://localhost:7079/swagger/index.html) swagger UI

---

- For adding additional validation to `SafeMathManager` business logic we only need to add validation class to our validators that implements `IMathValidator`
- `IMathValidator` provides polymorphic behavior for our validator.
- HealthCheck: https://localhost:7079/health