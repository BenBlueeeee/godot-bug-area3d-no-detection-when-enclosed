extends Area3D

func _process(_delta: float) -> void:
	print(get_overlapping_bodies())
