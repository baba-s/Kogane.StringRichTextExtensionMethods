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
        public static RichText Bold( this        RichText self )               => new( $"<b>{self.Text}</b>" );
        public static RichText Italic( this      RichText self )               => new( $"<i>{self.Text}</i>" );
        public static RichText Size( this        RichText self, int    size )  => new( $"<size={size}>{self.Text}</size>" );
        public static RichText Color( this       RichText self, string color ) => new( $@"<color={color}>{self.Text}</color>" );

        public static RichText Aqua( this      RichText self ) => self.Color( "aqua" );
        public static RichText Black( this     RichText self ) => self.Color( "black" );
        public static RichText Blue( this      RichText self ) => self.Color( "blue" );
        public static RichText Brown( this     RichText self ) => self.Color( "brown" );
        public static RichText Cyan( this      RichText self ) => self.Color( "cyan" );
        public static RichText Darkblue( this  RichText self ) => self.Color( "darkblue" );
        public static RichText Fuchsia( this   RichText self ) => self.Color( "fuchsia" );
        public static RichText Green( this     RichText self ) => self.Color( "green" );
        public static RichText Grey( this      RichText self ) => self.Color( "grey" );
        public static RichText Lightblue( this RichText self ) => self.Color( "lightblue" );
        public static RichText Lime( this      RichText self ) => self.Color( "lime" );
        public static RichText Magenta( this   RichText self ) => self.Color( "magenta" );
        public static RichText Maroon( this    RichText self ) => self.Color( "maroon" );
        public static RichText Navy( this      RichText self ) => self.Color( "navy" );
        public static RichText Olive( this     RichText self ) => self.Color( "olive" );
        public static RichText Orange( this    RichText self ) => self.Color( "orange" );
        public static RichText Purple( this    RichText self ) => self.Color( "purple" );
        public static RichText Red( this       RichText self ) => self.Color( "red" );
        public static RichText Silver( this    RichText self ) => self.Color( "silver" );
        public static RichText Teal( this      RichText self ) => self.Color( "teal" );
        public static RichText White( this     RichText self ) => self.Color( "white" );
        public static RichText Yellow( this    RichText self ) => self.Color( "yellow" );
    }
}