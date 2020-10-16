using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Platformer
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D texture;
        private Rectangle deelRectangle;
        private int schuifOp_X = 0;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            deelRectangle = new Rectangle(schuifOp_X, 0, 40, 85);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            texture = Content.Load<Texture2D>("spritesheetHero");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Crimson);

            _spriteBatch.Begin();
            _spriteBatch.Draw(texture,new Vector2(10,10), deelRectangle, Color.CornflowerBlue);
            _spriteBatch.End();

            schuifOp_X += 80;
            if (schuifOp_X > 700)
                schuifOp_X = 23;
            deelRectangle.X = schuifOp_X;
            base.Draw(gameTime);
        }
    }
}
