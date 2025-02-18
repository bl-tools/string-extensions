# string-extensions

Library provides extensions to String type to simplify code

```csharp
            var source = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. ";
            var template = "Lorem";
			
            //old version
            //var result = source.Contains(template, StringComparison.InvariantCultureIgnoreCase);
			
            //new version
            var result = source.ContainsIgnoreCase(template);//new version
```
