﻿using UnityEngine.EventSystems;
using System.Collections.Generic;

public interface IRecieveMessage : IEventSystemHandler {

	// この名前の関数はすべて呼ばれることになる
	void Hoge ();

	void UpdatePiecePosition();

	void UpdatePiecePosition(int a, Dictionary<string, object> d);
}
