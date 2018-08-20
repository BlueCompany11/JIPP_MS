using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIPP_MS
{
    public class Plane
    {
        public delegate void PlaneCrash();
        public delegate void PlaneSurvive();
        public event PlaneCrash PlaneCrashed;
        public event PlaneSurvive PlaneSurvived;

        int dx;
        int dy;
        bool alive = true;
        bool survived = false;
        public int Dx {
            get
            {
                return dx;
            }
            set
            {
                if (dx > MapWidth && survived == false)
                {
                    PlaneSurvived();
                }
                dx = value;
            }
        }
        public int Dy
        {
            get
            {
                return dy;
            }
            set
            {
                if (dy > MapHeight && alive == true)
                {
                    PlaneCrashed();
                }
                dy = value;
            }
        }
        public int MapWidth { get; private set; }
        
        public int MapHeight { get; private set; }
        public Plane(int mapWidth, int mapHeight)
        {
            MapWidth = mapWidth;
            MapHeight = mapHeight;
            PlaneCrashed += Plane_PlaneCrashed;
            PlaneSurvived += Plane_PlaneSurvived;
        }

        private void Plane_PlaneSurvived()
        {
            survived = true;
        }

        private void Plane_PlaneCrashed()
        {
            alive = false;
        }
    }
}
