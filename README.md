![Build&Test](https://github.com/adearriba/NationalDocumentValidator/workflows/Build&Test/badge.svg)

# National Document Validator
Para validar un documento solamente se debe obtener el validador por medio de **DocumentValidatorFactory** y ejecutar el método **GetValidator()** pasando un valor del enum Countries.

Después se ejecuta la función **IsValid** con el valor del documento a validar.

```csharp
var validator = DocumentValidatorFactory.GetValidator(Countries.ESP);
bool result = validator.IsValid("36120423G");
```
## Lista de Países implementados
Pais | ISO | Documentos
------------ | ------------- | -------------
España | ESP | NIF, NIE, Pasaporte
Francia | FRA | INSEE, Pasaporte
