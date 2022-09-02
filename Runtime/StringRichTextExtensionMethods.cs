namespace Kogane
{
    public static class StringRichTextExtensionMethods
    {
        public readonly struct RichText
        {
            internal string Text { get; }

            internal RichText( string text )
            {
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }

            public static implicit operator string( RichText richText ) => richText.Text;
        }

        public static RichText GetRichText( this string   self )               => new( self );
        public static RichText Bold( this in     RichText self )               => new( $"<b>{self.Text}</b>" );
        public static RichText Italic( this in   RichText self )               => new( $"<i>{self.Text}</i>" );
        public static RichText Size( this in     RichText self, int    size )  => new( $"<size={size}>{self.Text}</size>" );
        public static RichText Color( this in    RichText self, string color ) => new( $@"<color={color}>{self.Text}</color>" );

        public static RichText Aqua( this in      RichText self ) => self.Color( "aqua" );
        public static RichText Black( this in     RichText self ) => self.Color( "black" );
        public static RichText Blue( this in      RichText self ) => self.Color( "blue" );
        public static RichText Brown( this in     RichText self ) => self.Color( "brown" );
        public static RichText Cyan( this in      RichText self ) => self.Color( "cyan" );
        public static RichText Darkblue( this in  RichText self ) => self.Color( "darkblue" );
        public static RichText Fuchsia( this in   RichText self ) => self.Color( "fuchsia" );
        public static RichText Green( this in     RichText self ) => self.Color( "green" );
        public static RichText Grey( this in      RichText self ) => self.Color( "grey" );
        public static RichText Lightblue( this in RichText self ) => self.Color( "lightblue" );
        public static RichText Lime( this in      RichText self ) => self.Color( "lime" );
        public static RichText Magenta( this in   RichText self ) => self.Color( "magenta" );
        public static RichText Maroon( this in    RichText self ) => self.Color( "maroon" );
        public static RichText Navy( this in      RichText self ) => self.Color( "navy" );
        public static RichText Olive( this in     RichText self ) => self.Color( "olive" );
        public static RichText Orange( this in    RichText self ) => self.Color( "orange" );
        public static RichText Purple( this in    RichText self ) => self.Color( "purple" );
        public static RichText Red( this in       RichText self ) => self.Color( "red" );
        public static RichText Silver( this in    RichText self ) => self.Color( "silver" );
        public static RichText Teal( this in      RichText self ) => self.Color( "teal" );
        public static RichText White( this in     RichText self ) => self.Color( "white" );
        public static RichText Yellow( this in    RichText self ) => self.Color( "yellow" );
    }
}