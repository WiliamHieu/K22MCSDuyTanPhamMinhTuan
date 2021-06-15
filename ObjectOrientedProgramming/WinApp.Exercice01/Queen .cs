namespace Exercice01
{
    public class Queen : Ant
    {
        /// <summary>
        /// Initializes a new instance of the Queen class.
        /// </summary>
        public Queen()
        {
            Name = "Queen";
        }

        /// <summary>Override Damage function for Change Health value in Ant class, Health value between 0 to 100, Dead default is False, if Health < 20 then set Dead = True</summary>
        /// <param name="health">The number between 0 and 80.</param>
        public override void Damage(int health)
        {
            if (Health - health < 0) Health = 0;
            else Health -= health;

            if (Health < 20) Dead = true;
        }
    }
}
