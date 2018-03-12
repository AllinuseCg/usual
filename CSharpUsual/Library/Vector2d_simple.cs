using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usual
{
    struct Vector2d_simple
    {
        float m_x, m_y;
        public float x { get { return m_x; } set { m_x = value; } }
        public float y { get { return m_y; } set { m_y = value; } }
        public Vector2d_simple(float x,float y)
        {
            m_x = x;
            m_y = y;
        }



        public static Vector2d_simple operator +(Vector2d_simple a, Vector2d_simple b)
        {
            return new Vector2d_simple(a.x + b.x, a.y + b.y);
        }
        public static Vector2d_simple operator -(Vector2d_simple a, Vector2d_simple b)
        {
            return new Vector2d_simple(a.x - b.x, a.y - b.y);
        }
        public static Vector2d_simple operator *(Vector2d_simple v, float f)
        {
            return new Vector2d_simple(v.x * f, v.y * f);
        }
        public static Vector2d_simple ClampInOne(Vector2d_simple p)
        {
            p.x = p.x <= 0 ? 0 : (p.x >= 1 ? 1 : p.x);
            //p.y = p.y <= 0 ? 0 : (p.y >= 1 ? 1 : p.y);
            return p;
        }

        public static Vector2d_simple LerpInRange(Vector2d_simple a, Vector2d_simple b, float alpha)
        {
            alpha = alpha < 0 ? 0 : (alpha > 1 ? 1 : alpha);
            return LerpWithoutRange(a, b, alpha);
        }
        public static Vector2d_simple LerpWithoutRange(Vector2d_simple a, Vector2d_simple b, float alpha)
        {
            Vector2d_simple delta = a - b;
            return a - delta * alpha;
        }
    }
}
