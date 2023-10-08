using System;

namespace TrigonometryLibrary
{
    public class TrigonometryCalculator
    {
        public static double CalculateOppositeSideUsingSine(TrigonometryModel model)
        {
            return Math.Sin(DegreesToRadians(model.Angle)) * model.Hypotenuse;
        }

        public static double CalculateOppositeSideUsingTan(TrigonometryModel model)
        {
            return Math.Tan(DegreesToRadians(model.Angle)) * model.Adjacent;
        }

        public static double CalculateHypotenuseUsingSine(TrigonometryModel model)
        {
            return model.Opposite / Math.Sin(DegreesToRadians(model.Angle));
        }

        public static double CalculateHypotenuseUsingCosine(TrigonometryModel model)
        {
            return model.Adjacent / Math.Cos(DegreesToRadians(model.Angle));
        }

        public static double CalculateAdjacentSideUsingCosine(TrigonometryModel model)
        {
            return model.Hypotenuse * Math.Cos(DegreesToRadians(model.Angle));
        }

        public static double CalculateAdjacentSideUsingTan(TrigonometryModel model)
        {
            return model.Opposite / Math.Tan(DegreesToRadians(model.Angle));
        }

        public static double CalculateAngleUsingSine(TrigonometryModel model)
        {
            return RadiansToDegrees(Math.Asin(model.Opposite / model.Hypotenuse));
        }

        public static double CalculateAngleUsingCosine(TrigonometryModel model)
        {
            return RadiansToDegrees(Math.Acos(model.Adjacent / model.Hypotenuse));
        }

        public static double CalculateAngleUsingTan(TrigonometryModel model)
        {
            return RadiansToDegrees(Math.Atan(model.Opposite / model.Adjacent));
        }

        public static double CalculateRadianceBasedOnOppositeAndHypotenuse(TrigonometryModel model)
        {
            return Math.Asin(model.Opposite / model.Hypotenuse);
        }

        public static double CalculateRadianceBasedOnAngle(TrigonometryModel model)
        {
            return DegreesToRadians(model.Angle);
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0);
        }

        private static double RadiansToDegrees(double radians)
        {
            return radians * (180.0 / Math.PI);
        }
    }
}
