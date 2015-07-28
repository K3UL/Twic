# Twic
extension to convert a number to words (decimal, int, float, double), currently supports english and spanish.

# Example
```
//supports int, double, decimal, and float
decimal aNumber = 2137912;

//next line will detect language according to CultureInfo.CurrentCulture
var auto = aNumber.Twic();

 //force English
var forceEnglish = aNumber.Twic(Language.English);

//force spanish
var forceSpanish = aNumber.Twic(Language.Spanish);

```

#NuGet
```
Install-Package Twic
```
