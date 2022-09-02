# Kogane String Rich Text Extension Methods

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        Debug.Log( "ピカチュウ".GetRichText().Bold() );
        Debug.Log( "ピカチュウ".GetRichText().Italic() );
        Debug.Log( "ピカチュウ".GetRichText().Size( 25 ) );
        Debug.Log( "ピカチュウ".GetRichText().Aqua() );
        Debug.Log( "ピカチュウ".GetRichText().Black() );
        Debug.Log( "ピカチュウ".GetRichText().Blue() );
        Debug.Log( "ピカチュウ".GetRichText().Brown() );
        Debug.Log( "ピカチュウ".GetRichText().Cyan() );
        Debug.Log( "ピカチュウ".GetRichText().Darkblue() );
        Debug.Log( "ピカチュウ".GetRichText().Fuchsia() );
        Debug.Log( "ピカチュウ".GetRichText().Green() );
        Debug.Log( "ピカチュウ".GetRichText().Grey() );
        Debug.Log( "ピカチュウ".GetRichText().Lightblue() );
        Debug.Log( "ピカチュウ".GetRichText().Lime() );
        Debug.Log( "ピカチュウ".GetRichText().Magenta() );
        Debug.Log( "ピカチュウ".GetRichText().Maroon() );
        Debug.Log( "ピカチュウ".GetRichText().Navy() );
        Debug.Log( "ピカチュウ".GetRichText().Olive() );
        Debug.Log( "ピカチュウ".GetRichText().Orange() );
        Debug.Log( "ピカチュウ".GetRichText().Purple() );
        Debug.Log( "ピカチュウ".GetRichText().Red() );
        Debug.Log( "ピカチュウ".GetRichText().Silver() );
        Debug.Log( "ピカチュウ".GetRichText().Teal() );
        Debug.Log( "ピカチュウ".GetRichText().White() );

        Debug.Log( "ピカチュウ".GetRichText().Bold().Italic().Aqua() );
    }
}
```