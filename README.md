# National Document Validator
Para validar un documento solamente se debe obtener el validador por medio de **DocumentValidatorFactory** y ejecutar el m�todo **GetValidator(string ISO)** pasando el valor ISO de 3 caracteres de pa�s.

Despu�s se ejecuta la funci�n **IsValid** con el valor del documento a validar.

```csharp
var validator = DocumentValidatorFactory.GetValidator("ESP");
bool result = validator.IsValid("36120423G");
```