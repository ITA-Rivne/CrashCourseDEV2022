using System;
using System.Collections.Generic;
 
namespace Materials
{ 
    public class Materials
    {
        private float width, height, length,rotate;
        private string type;
        public Materials(string type,float width, float height, float length )
        {
            this.type = type;
            this.width = width;
            this.length = length;
            this.height = height;
            this.rotate = 0;
        }
        public void SetRotate(float rotate)
        {
            this.rotate = rotate;

        }
        public float GetPerimeter()
        {
            return (this.width + this.length)*2;
        }
        public float GetArea()
        {
            return this.width * this.length;

        }
        public float GetVolume()
        {
            return this.GetArea()* this.height;
        }



    }
}