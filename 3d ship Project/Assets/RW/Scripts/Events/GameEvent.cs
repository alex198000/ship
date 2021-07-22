using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Game Event/Game Event")] // 1 ��������� GameEvent � �������� ������ � Asset Menu.
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners = new List<GameEventListener>(); // 3 ������ GameEventListeners, ������� ����� ��������� �� GameEvent.
    public void Raise() // 4 ����� ��� ������ ���� ����������� GameEvent.
    {
        for (int i = listeners.Count - 1; i >= 0; i--) // 5 ��������� ����������� GameEventListener ����� ������ ���������� (��������� ������, ������ �����).
        {
            listeners[i].OnEventRaised(); // 6 ����� ������� UnityEvent GameEventListeners.
        }
    }

    public void RegisterListener(GameEventListener listener) // 7 �����, ����������� GameEventListeners ����������� �� ���� GameEvent.
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener) // 8 �����, ����������� GameEventListeners ������������ �� ����� GameEvent.
    {
        listeners.Remove(listener);
    }
}
