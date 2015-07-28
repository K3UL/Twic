# Twic
extension to convert a number to words (decimal, int, float, double), currently supports english and spanish.

# Example
```
//supports int, double, decimal, and float
decimal aNumber = 2.99;

//next line will detect language according to CultureInfo.CurrentCulture
string auto = aNumber.Twic(); //returns 'two' or 'dos' depending on CultureInfo

 //force English
string forceEnglish = aNumber.Twic(Language.English); // 'two 99/100'

//force spanish
string forceSpanish = aNumber.Twic(Language.Spanish);  // 'dos 99/100'

//Use int to remove cents
string integerString = 2.Twic(Language.English) //returns 'two'

```

#NuGet
```
Install-Package Twic
```
