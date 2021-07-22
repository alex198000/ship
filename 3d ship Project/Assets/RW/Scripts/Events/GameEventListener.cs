using UnityEngine.Events; // 1 ���������� ������������� ������ UnityEvent.
using UnityEngine;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent; // 2 GameEvent, �� ������� ����� �������� ���� GameEventListener.
    [SerializeField] private UnityEvent response; // 3 ������ UnityEvent, ������� ����� ����������, ��� ��������� �������� GameEvent ����� GameEventListener.

    private void OnEnable() // 4 �������� GameEvent � GameEventListener, ����� ���� GameObject �������.
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable() // 5 ������� GameEvent �� GameEventListener, ����� ���� GameObject ��������.
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised() // 6 ���������� ��� ��������� GameEvent, ���������� � ������ ���������� GameEventListener ������� UnityEvent.
    {
        response.Invoke();
    }
}

