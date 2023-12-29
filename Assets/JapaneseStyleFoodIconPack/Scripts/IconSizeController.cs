using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JapaneseStyleFoodIconPack { 

public class IconSizeController : MonoBehaviour
{
        public GridLayoutGroup gridLayoutGroup;

        public void ChangeImageSize(int size)
        {
            gridLayoutGroup.cellSize = new Vector2(size, size);

        }


    }
}