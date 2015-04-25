# Perl Language Service - README

Emeraldwalk.PerlLanguageService is a **Perl language service** extension for Visual Studio.

### Implemented Features
* Perl syntax highlighting
* Brace matching
* Outlining

### Adding File Extensions
As far as I can tell file extensions have to be added via code attributes.
If you need additional extensions, you can add additional ProvideLanguageExtension attributes to Emeraldwalk_LanguageServicesPackage.

For example, to add .myext extension to list of extensions handled by the service:
```c#
[ProvideLanguageExtension(typeof(PerlLanguageService), ".pl")]
[ProvideLanguageExtension(typeof(PerlLanguageService), ".pm")]
[ProvideLanguageExtension(typeof(PerlLanguageService), ".myext")]
public sealed class Emeraldwalk_LanguageServicesPackage : Package
{
...
}
```
You should also add any extensions to PerlLanguageService.GetFormatFilterList():
```
public override string GetFormatFilterList()
{
    return "Perl Files (*.pl)|*.pl|Perl Modules (*.pm)|*.pm|My Extension (*.myext)|*.myext|";
}
```

### Releases (under Releases folder)
* 1.0.0 - Initial release supporting .pl and .pm file extensions.