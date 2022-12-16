using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldChechker : MonoBehaviour
{
    [SerializeField] private TMP_InputField upLeft;
    [SerializeField] private TMP_InputField up;
    [SerializeField] private TMP_InputField upRight;
    [SerializeField] private TMP_InputField centerLeft;
    [SerializeField] private TMP_InputField center;
    [SerializeField] private TMP_InputField centerRight;
    [SerializeField] private TMP_InputField downLeft;
    [SerializeField] private TMP_InputField down;
    [SerializeField] private TMP_InputField downRight;
    [SerializeField] private GameObject winState;
    [SerializeField] private GameObject drawState;
    [SerializeField] private TextMeshProUGUI instructions;
    [SerializeField] private TextMeshProUGUI nameOfGame;
    [SerializeField] private TextMeshProUGUI congrulations;
    [SerializeField] private TextMeshProUGUI playAgainText;
    [SerializeField] private TextMeshProUGUI draw;
    [SerializeField] private TextMeshProUGUI tryAgainText;
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button tryAgainButton;

    private bool notWin = true;
    private bool turn = true;

    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    void Update()
    {
        RightChar();
        WinState();
        DrawState();
    }

    private IEnumerator ChangeColor()
    {
        instructions.color = new Color(Random.value, Random.value, Random.value);
        nameOfGame.color = new Color(Random.value, Random.value, Random.value);
        congrulations.color = new Color(Random.value, Random.value, Random.value);
        playAgainText.color = new Color(Random.value, Random.value, Random.value);
        draw.color = new Color(Random.value, Random.value, Random.value);
        tryAgainText.color = new Color(Random.value, Random.value, Random.value);
        playAgainButton.GetComponent<Image>().color = new Color(Random.value, Random.value, Random.value);
        tryAgainButton.GetComponent<Image>().color = new Color(Random.value, Random.value, Random.value);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(ChangeColor());
    }

    private void RightChar()
    {
        switch (turn)
        {
            case true:
                if (upLeft.interactable == true)
                {
                    if (upLeft.text == "x" || upLeft.text == "X")
                    {
                        upLeft.text = upLeft.text;
                        upLeft.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        upLeft.text = null;
                    }
                }

                if (up.interactable == true)
                {
                    if (up.text == "x" || up.text == "X")
                    {
                        up.text = up.text;
                        up.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        up.text = null;
                    }
                }

                if (upRight.interactable == true)
                {
                    if (upRight.text == "x" || upRight.text == "X")
                    {
                        upRight.text = upRight.text;
                        upRight.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        upRight.text = null;
                    }
                }


                if (centerLeft.interactable == true)
                {
                    if (centerLeft.text == "x" || centerLeft.text == "X")
                    {
                        centerLeft.text = centerLeft.text;
                        centerLeft.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        centerLeft.text = null;
                    }
                }

                if (center.interactable == true)
                {
                    if (center.text == "x" || center.text == "X")
                    {
                        center.text = center.text;
                        center.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        center.text = null;
                    }
                }

                if (centerRight.interactable == true)
                {
                    if (centerRight.text == "x" || centerRight.text == "X")
                    {
                        centerRight.text = centerRight.text;
                        centerRight.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        centerRight.text = null;
                    }
                }


                if (downLeft.interactable == true)
                {
                    if (downLeft.text == "x" || downLeft.text == "X")
                    {
                        downLeft.text = downLeft.text;
                        downLeft.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        downLeft.text = null;
                    }
                }

                if (down.interactable == true)
                {
                    if (down.text == "x" || down.text == "X")
                    {
                        down.text = down.text;
                        down.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        down.text = null;
                    }
                }

                if (downRight.interactable == true)
                {
                    if (downRight.text == "x" || downRight.text == "X")
                    {
                        downRight.text = downRight.text;
                        downRight.interactable = false;
                        turn = false;
                    }
                    else
                    {
                        downRight.text = null;
                    }
                }
                break;
            case false:
                if (upLeft.interactable == true)
                {
                    if (upLeft.text == "o" || upLeft.text == "O")
                    {
                        upLeft.text = upLeft.text;
                        upLeft.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        upLeft.text = null;
                    }
                }

                if (up.interactable == true)
                {
                    if (up.text == "o" || up.text == "O")
                    {
                        up.text = up.text;
                        up.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        up.text = null;
                    }
                }

                if (upRight.interactable == true)
                {
                    if (upRight.text == "o" || upRight.text == "O")
                    {
                        upRight.text = upRight.text;
                        upRight.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        upRight.text = null;
                    }
                }


                if (centerLeft.interactable == true)
                {
                    if (centerLeft.text == "o" || centerLeft.text == "O")
                    {
                        centerLeft.text = centerLeft.text;
                        centerLeft.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        centerLeft.text = null;
                    }
                }

                if (center.interactable == true)
                {
                    if (center.text == "o" || center.text == "O")
                    {
                        center.text = center.text;
                        center.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        center.text = null;
                    }
                }

                if (centerRight.interactable == true)
                {
                    if (centerRight.text == "o" || centerRight.text == "O")
                    {
                        centerRight.text = centerRight.text;
                        centerRight.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        centerRight.text = null;
                    }
                }


                if (downLeft.interactable == true)
                {
                    if (downLeft.text == "o" || downLeft.text == "O")
                    {
                        downLeft.text = downLeft.text;
                        downLeft.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        downLeft.text = null;
                    }
                }

                if (down.interactable == true)
                {
                    if (down.text == "o" || down.text == "O")
                    {
                        down.text = down.text;
                        down.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        down.text = null;
                    }
                }

                if (downRight.interactable == true)
                {
                    if (downRight.text == "o" || downRight.text == "O")
                    {
                        downRight.text = downRight.text;
                        downRight.interactable = false;
                        turn = true;
                    }
                    else
                    {
                        downRight.text = null;
                    }
                }
                break;
        }
    }

    private void WinState()
    {
        if (upLeft.text == "x" && up.text == "x" && upRight.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "x" && centerLeft.text == "x" && downLeft.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (up.text == "x" && center.text == "x" && down.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (downLeft.text == "x" && down.text == "x" && downRight.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (centerLeft.text == "x" && center.text == "x" && centerRight.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "x" && centerRight.text == "x" && downRight.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "x" && center.text == "x" && downRight.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "x" && center.text == "x" && downLeft.text == "x")
        {
            notWin = false;
            winState.SetActive(true);
        }

        if (upLeft.text == "X" && up.text == "X" && upRight.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "X" && centerLeft.text == "X" && downLeft.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (up.text == "X" && center.text == "X" && down.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (downLeft.text == "X" && down.text == "X" && downRight.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (centerLeft.text == "X" && center.text == "X" && centerRight.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "X" && centerRight.text == "X" && downRight.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "X" && center.text == "X" && downRight.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "X" && center.text == "X" && downLeft.text == "X")
        {
            notWin = false;
            winState.SetActive(true);
        }

        if (upLeft.text == "o" && up.text == "o" && upRight.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "o" && centerLeft.text == "o" && downLeft.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (up.text == "o" && center.text == "o" && down.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (downLeft.text == "o" && down.text == "o" && downRight.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (centerLeft.text == "o" && center.text == "o" && centerRight.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "o" && centerRight.text == "o" && downRight.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "o" && center.text == "o" && downRight.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "o" && center.text == "o" && downLeft.text == "o")
        {
            notWin = false;
            winState.SetActive(true);
        }

        if (upLeft.text == "O" && up.text == "O" && upRight.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "O" && centerLeft.text == "O" && downLeft.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (up.text == "O" && center.text == "O" && down.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (downLeft.text == "O" && down.text == "O" && downRight.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (centerLeft.text == "O" && center.text == "O" && centerRight.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "O" && centerRight.text == "O" && downRight.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upLeft.text == "O" && center.text == "O" && downRight.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
        if (upRight.text == "O" && center.text == "O" && downLeft.text == "O")
        {
            notWin = false;
            winState.SetActive(true);
        }
    }

    private void DrawState()
    {
        if (notWin)
        {
            if ((upLeft.text == "x" || upLeft.text == "X" || upLeft.text == "o" || upLeft.text == "O")
            && (up.text == "x" || up.text == "X" || up.text == "o" || up.text == "O")
            && (upRight.text == "x" || upRight.text == "X" || upRight.text == "o" || upRight.text == "O")
            && (centerLeft.text == "x" || centerLeft.text == "X" || centerLeft.text == "o" || centerLeft.text == "O")
            && (center.text == "x" || center.text == "X" || center.text == "o" || center.text == "O")
            && (centerRight.text == "x" || centerRight.text == "X" || centerRight.text == "o" || centerRight.text == "O")
            && (downLeft.text == "x" || downLeft.text == "X" || downLeft.text == "o" || downLeft.text == "O")
            && (down.text == "x" || down.text == "X" || down.text == "o" || down.text == "O")
            && (downRight.text == "x" || downRight.text == "X" || downRight.text == "o" || downRight.text == "O"))
            {
                drawState.SetActive(true);
            }
        }
    }

    public void Again()
    {
        upLeft.text = null;
        upLeft.interactable = true;
        up.text = null;
        up.interactable = true;
        upRight.text = null;
        upRight.interactable = true;
        centerLeft.text = null;
        centerLeft.interactable = true;
        center.text = null;
        center.interactable = true;
        centerRight.text = null;
        centerRight.interactable = true;
        downLeft.text = null;
        downLeft.interactable = true;
        down.text = null;
        down.interactable = true;
        downRight.text = null;
        downRight.interactable = true;
        winState.SetActive(false);
        drawState.SetActive(false);
        notWin = true;
    }
}
