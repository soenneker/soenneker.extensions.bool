[![](https://img.shields.io/nuget/v/soenneker.extensions.bool.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.bool/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.bool/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.bool/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.bool.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.bool/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.bool/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.bool/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Bool

Formats a non-nullable Boolean as fixed English `Yes`/`No` text.

## Installation

```bash
dotnet add package Soenneker.Extensions.Bool
```

## Usage

```csharp
using Soenneker.Extensions.Bool;

string enabled = true.ToYesNo();          // "Yes"
string disabled = false.ToYesNo();        // "No"

string lowerEnabled = true.ToYesNoLower();  // "yes"
string lowerDisabled = false.ToYesNoLower(); // "no"
```

Both methods are deterministic and culture-invariant:

- `ToYesNo()` returns `"Yes"` or `"No"`.
- `ToYesNoLower()` returns `"yes"` or `"no"`.

The output is intended for simple display or fixed text contracts. It is not localized, does not parse strings back to Boolean values, and does not change JSON Boolean serialization (`true`/`false`). Use application localization resources when the text is user-facing in multiple languages.

These extensions accept `bool`, not `bool?`. Use the separate nullable-Boolean extensions when a null value needs its own representation.
