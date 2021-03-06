﻿using UnityEngine.EventSystems;

public interface IPublisher
{
    void Publish(MessageLayer m,  string e);
    void Publish<T>(MessageLayer m, string e, T args);
}
