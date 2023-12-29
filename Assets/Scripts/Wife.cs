using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wife
{
    [CreateAssetMenu(fileName = "WifeData", menuName = "ScriptableObjects/Wife", order = 1)]
    public class Wife : ScriptableObject
    {
        public string wifeName;
        public Personality personality;
        public KeyItem keyItem;
        public Sign sign;
    }

    public enum Personality
    {
        None,
        Clumsy,
        Tomboy,
        Violent,
        Energetic,
        emotionless,
        chuunibyou,
        Cool,
        Manipulative,
        Kind,
        Araara,
        Laidback,
        Authoritative,
        Ditzy,
        Gentle,
        Psychotic,
        Yandere,
        Traditional,
        Depressed,
        Honest,
        Tsundere,
        Otaku,
        patient,
    }

    public enum KeyItem
    {
        None,
        CigaretteBox,
        EngagementRing,
        LipStick,
        RoomKey
    }

    public enum Sign
    {
        None,
        LackOfCommunication,
        Contempt,
        Defensive,
        Lying,
        Distancing,
        PersonalAttack,
        LackOfIntimacy,
        ChangeInBehaviour,
        Secrecy
    }
}



