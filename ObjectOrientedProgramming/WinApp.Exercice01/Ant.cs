namespace Exercice01
{
    public class Ant
    {
        /// <summary>
        /// Gets or sets the Health property, Health value between 0 to 100.
        /// </summary>
        public int Health { get; set; } = 100;

        /// <summary>
        /// Gets or sets the Dead property, default value is false. Depending on the head value will be changed to True.
        /// </summary>
        public bool Dead { get; set; } = false;

        /// <summary>
        /// Gets or sets the Name property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Virtual function for override in Child class for change Health and Dead value
        /// </summary>
        public virtual void Damage (int health) { }
    }
}
