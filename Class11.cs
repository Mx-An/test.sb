void PassMaze(Maze* m, Position enter, Stack* shortPath)
{
	Stack Path;
	StackInit(&Path);
	assert(m != NULL);
	if (!IsValidEnter(m, enter))//如果入口不合法
	{
		printf("入口不合法！！！\n");
		return;
	}
	else
		_GetMazeshortPath(m, enter, enter, &Path, shortPath);
}
