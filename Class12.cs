using System;
void _GetMazeshortPath(Maze* m, Position cur, Position enter, Stack* Path, Stack* shortPath)
{
	Position next;
	//判断是否为出口，若为出口，保存最短路径，Pop
	if (IsExit(m, cur, enter))
	{
		StackPush(Path, cur);
		if (StackSize(Path) < StackSize(shortPath) || StackEmpty(shortPath))
		{
			SaveshortPath(shortPath, Path);
		}
		StackPop(Path);
		//return;
	}
	if (StackEmpty(Path))
		m->_map[enter._x][enter._y] = 2;
	StackPush(Path, cur);

	//上
	next = cur;
	next._x -= 1;
	if (IsPass(m, cur, next))
	{
		m->_map[next._x][next._y] = m->_map[cur._x][cur._y] + 1;//标记
		_GetMazeshortPath(m, next, enter, Path, shortPath);
	}

	//左
	next = cur;
	next._y -= 1;
	if (IsPass(m, cur, next))
	{
		m->_map[next._x][next._y] = m->_map[cur._x][cur._y] + 1;
		_GetMazeshortPath(m, next, enter, Path, shortPath);
	}


	//右
	next = cur;
	next._y += 1;
	if (IsPass(m, cur, next))
	{
		m->_map[next._x][next._y] = m->_map[cur._x][cur._y] + 1;
		_GetMazeshortPath(m, next, enter, Path, shortPath);
	}

	//下
	next = cur;
	next._x += 1;
	if (IsPass(m, cur, next))
	{
		m->_map[next._x][next._y] = m->_map[cur._x][cur._y] + 1;
		_GetMazeshortPath(m, next, enter, Path, shortPath);
	}

	//说明上步走错了
	StackPop(Path);
}
