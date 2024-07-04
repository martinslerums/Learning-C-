using System;


namespace LessonFive
{
    class CantTeleport : ITeleports
    {
        public string Teleport()
        {
            return "Fails at Teleporting";
        }
    }
}