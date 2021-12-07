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
