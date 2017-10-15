using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usual
{
    struct Bezier
    {
        Vector2d_simple m_a, m_b;
        public Vector2d_simple a { get { return m_a; } set { m_a = value; } }
        public Vector2d_simple b { get { return m_b; } set { m_b = value; } }
        public Bezier(Vector2d_simple a, Vector2d_simple b)
        {
            m_a = Vector2d_simple.ClampInOne(a);
            m_b = Vector2d_simple.ClampInOne(b);
        }

        public Vector2d_simple getValueByAlpha(float alpha)
        {
            Vector2d_simple zero = new Vector2d_simple(0, 0);
            Vector2d_simple one = new Vector2d_simple(1, 1);

            Vector2d_simple in_zero_a = Vector2d_simple.LerpInRange(zero, a, alpha);
            Vector2d_simple in_a_b = Vector2d_simple.LerpInRange(a, b, alpha);
            Vector2d_simple in_b_one = Vector2d_simple.LerpInRange(b, one, alpha);

            Vector2d_simple in_zero_a_b= Vector2d_simple.LerpInRange(in_zero_a, in_a_b, alpha);
            Vector2d_simple in_a_b_one = Vector2d_simple.LerpInRange(in_a_b, in_b_one, alpha);

            return Vector2d_simple.LerpInRange(in_zero_a_b, in_a_b_one, alpha);
            //return new Vector2d_simple(nazofun(t, 0, a.x, b.x, 1), nazofun(t, 0, a.y, b.y, 1));   //化简的算式？
        }
        float nazofun(float t, float a, float b, float c, float d)
        {
            float k = 1 - t;
            //a * k^3 + 3 * b * k^2 * t + 3 * c * k * t^2 + d * t^3
            return k * k * k * a + 3 * k * k * t * b + 3 * k * t * t * c + t * t * t * d;
        }
        public Vector2d_simple getValueByT(float t)
        {
            return new Vector2d_simple(0, 0);
        }

       
    }
}
