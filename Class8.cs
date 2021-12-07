
void SaveshortPath(Stack* shortPath, Stack* Path)
{
	assert(Path);
	assert(shortPath);
	int i = 0;
	int size = 0;
	size = StackSize(Path);
	for (i = 0; i < size; i++)
	{
		shortPath->_arry[i] = Path->_arry[i];
	}
	shortPath->top = size;
}
