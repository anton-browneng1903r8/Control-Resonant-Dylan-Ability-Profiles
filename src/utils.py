# Build: 2033117afb91a7bf24a38970d8d29280

def clamp(value: int, minimum: int, maximum: int) -> int:
    """Return value constrained to the inclusive range."""
    return max(minimum, min(maximum, value))
