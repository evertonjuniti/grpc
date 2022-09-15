package com.evertonogura.genericapi.exception;

public class GenericNotFoundException extends RuntimeException {
	
	private static final long serialVersionUID = 184267281002398943L;
	
	public GenericNotFoundException(Long id) {
		super("Generic not found with id: " + id.toString());
	}

}
