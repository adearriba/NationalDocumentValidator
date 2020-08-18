![Build&Test](https://github.com/adearriba/NationalDocumentValidator/workflows/Build&Test/badge.svg)

# National Document Validator
Para validar un documento solamente se debe obtener el validador por medio de **DocumentValidatorFactory** y ejecutar el método **GetValidator(string ISO)** pasando el valor ISO de 3 caracteres de país.

Después se ejecuta la función **IsValid** con el valor del documento a validar.

```csharp
var validator = DocumentValidatorFactory.GetValidator("ESP");
bool result = validator.IsValid("36120423G");
```
## Lista de Países implementados
Pais | ISO | Documentos
------------ | ------------- | -------------
España | ESP | NIF, NIE, Pasaporte
Francia | FRA | INSEE, Pasaporte
