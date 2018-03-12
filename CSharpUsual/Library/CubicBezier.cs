using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usual
{
    struct CubicBezier
    {
        Vector2d_simple m_a, m_b;
        public Vector2d_simple A { get { return m_a; } set { m_a = value; } }
        public Vector2d_simple B { get { return m_b; } set { m_b = value; } }
        public CubicBezier(Vector2d_simple a, Vector2d_simple b)
        {
            m_a = Vector2d_simple.ClampInOne(a);
            m_b = Vector2d_simple.ClampInOne(b);
        }

        public Vector2d_simple getPointByAlpha(float alpha)
        {
            #region 完整算式
            /*
            Vector2d_simple zero = new Vector2d_simple(0, 0);
            Vector2d_simple one = new Vector2d_simple(1, 1);

            Vector2d_simple in_zero_a = Vector2d_simple.LerpInRange(zero, a, alpha);
            Vector2d_simple in_a_b = Vector2d_simple.LerpInRange(a, b, alpha);
            Vector2d_simple in_b_one = Vector2d_simple.LerpInRange(b, one, alpha);

            Vector2d_simple in_zero_a_b= Vector2d_simple.LerpInRange(in_zero_a, in_a_b, alpha);
            Vector2d_simple in_a_b_one = Vector2d_simple.LerpInRange(in_a_b, in_b_one, alpha);

            return Vector2d_simple.LerpInRange(in_zero_a_b, in_a_b_one, alpha);
            */
            #endregion
            return new Vector2d_simple(getPointbyAlpha_2num(alpha, A.x, B.x), getPointbyAlpha_2num(alpha, A.y, B.y));   //化简的算式
        }

        //t=alpha,a b为控制点，o g为起终点
        float getPoinbyAlpha_4num(float t, float o, float a, float b, float g)
        {
            float k = 1 - t;
            //a * k^3 + 3 * b * k^2 * t + 3 * c * k * t^2 + d * t^3
            return k * k * k * o + 3 * k * k * t * a + 3 * k * t * t * b + t * t * t * g;
        }

        //t=alpha
        float getPointbyAlpha_2num(float t, float a, float b)
        {
            float k = 1 - t;
            //a=0,d=1
            return 3 * k * k * t * a + 3 * k * t * t * b + t * t * t;
        }

        // t是时间，也是图形的x坐标，求y坐标
        public float getYByX(float t)
        {
            return (t + 3 * B.x * t * t - 3 * A.x * t) * (1 - 3 * A.y - 3 * B.y) / (1 - 3 * A.x - 3 * B.x) + 3 * A.y * t - 3 * B.y * t * t;
        }

        public Vector2d_simple getPointByX(float x)
        {
            return new Vector2d_simple(x, getPointbyAlpha_2num(judgeAlphaByX(x), A.y, B.y));
        }

        // 二分法求在f(x)处近似的alpha值
        // Threshold是分辨率的平方
        public float judgeAlphaByX(float x,float Threshold = 0.00001f)
        {
            var beginT = 0f;
            var endT = 1f;
            var midT = 0.5f;
            var midTx = getPointbyAlpha_2num(midT, A.x, B.x);
            var range = midTx - x;
            int i = 0;
            while (i++ < 100)
            {
                if (range * range < Threshold)
                {
                    Console.WriteLine("i = " + i);
                    return midT;
                }
                else if (x > midTx)
                {
                    beginT = midT;
                }
                else
                {
                    endT = midT;
                }
                midT = (beginT + endT) / 2;
                midTx = getPointbyAlpha_2num(midT, A.x, B.x);
                range = midTx - x;
            }

            Console.WriteLine("超次数跳出");
            return midT;
        }
    }
}
