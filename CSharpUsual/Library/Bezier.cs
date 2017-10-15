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

        public Vector2d_simple getValueAtAlpha(float alpha)
        {
            Vector2d_simple zero = new Vector2d_simple(0, 0);
            Vector2d_simple one = new Vector2d_simple(1, 1);

            Vector2d_simple in_zero_a = Vector2d_simple.LerpInRange(zero, a, alpha);
            Vector2d_simple in_a_b = Vector2d_simple.LerpInRange(a, b, alpha);
            Vector2d_simple in_b_one = Vector2d_simple.LerpInRange(b, one, alpha);

            Vector2d_simple in_zero_a_b= Vector2d_simple.LerpInRange(in_zero_a, in_a_b, alpha);
            Vector2d_simple in_a_b_one = Vector2d_simple.LerpInRange(in_a_b, in_b_one, alpha);

            return Vector2d_simple.LerpInRange(in_zero_a_b, in_a_b_one, alpha);
        }

    }
}
