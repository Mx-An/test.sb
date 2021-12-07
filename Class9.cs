int IsPass(Maze* m, Position cur, Position next)
{
	assert(m != NULL);
	if (m->_map[next._x][next._y] > m->_map[cur._x][cur._y] || m->_map[next._x][next._y] == 1)
		return 1;

	return 0;
}
